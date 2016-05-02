package com.example.ss.cardsmspoint;

import android.content.ContentResolver;
import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import android.telephony.SmsMessage;
import android.util.Log;

import java.util.ArrayList;

/**
 * Created by ss on 2016-04-04.
 */
public class SmsInbox {

    private Cursor c;

    private String[] paymentList= null;
    private String[] internetPayment = null;

    private String won = null, time = null, enterpriseName = null;
    private StringBuffer sb;

    public SmsInbox(){
        sb = new StringBuffer();
    }

    public void inbox(Context context, String receiveNumber, ArrayList<UseCardList> cardLists){
        // Create Inbox box URI
        //receiveNumber = "01032351228";
        Uri inboxURI = Uri.parse("content://sms/inbox");

        // List required columns
        String[] reqCols = new String[] { "_id", "address", "body" };

        // Get Content Resolver object, which will deal with Content
        // Provider
        ContentResolver cr = context.getContentResolver();

        // Fetch Inbox SMS Message from Built-in Content Provider
        c = cr.query(inboxURI, reqCols, "address LIKE "+receiveNumber, null, null);
        Log.v("testNumber", receiveNumber);
        //Log.v("testNumber",c.getString(0));
        cardLists.clear();
        // 버튼 클릭 시 리스트가 계속 쌓이지 않게 하기 위해 지워줌.

        if(c != null) {
            while (c.moveToNext()) {
                Log.d("TAG : ", c.getString(2));
                // query를 하여 받아온 리스트들이 끝날 때 까지 돌아감.
                paymentList = c.getString(2).split("\n");
                // SMS Parsing의 내용은 \n으로 구분한다.

                for (int i = 0; i < paymentList.length; i++) {
                    internetPayment = paymentList[i].split(" ");

                    if (i == paymentList.length - 1) {
                        if (receiveNumber.equals("15881788")) {
                            if(paymentList[i].indexOf("사용")!=-1){
                                sb.insert(0, paymentList[i]);
                                enterpriseName = sb.substring(0, paymentList[i].indexOf("사용"));
                                sb.delete(0, sb.length());
                            }

                        }//kb bank 사용 delete
                        else if (receiveNumber.equals("15881600")) {
                            enterpriseName = paymentList[i];
                        }
                    } // Enterprise Name

                    else if (paymentList[i].indexOf("원") != -1) {
                        if (paymentList[i].indexOf(",") != -1 && internetPayment.length <= 1)
                            won = paymentList[i];
                            // 일반 매장 결제 시

                        else if(internetPayment.length > 1){
                            for (int j = 0; j < internetPayment.length; j++) {
                                if (internetPayment[j].indexOf(",") != -1)
                                    won = internetPayment[j];
                                    // price
                                else if(internetPayment[j].indexOf("/") != -1)
                                    sb.insert(0, internetPayment[j] + " ");

                                else if(internetPayment[j].indexOf(":") != -1){
                                    sb.append(internetPayment[j]);
                                    time = sb.toString();
//                                    time = c.getString(c.getColumnIndex("date"));
//
                                    sb.delete(0, sb.length());
                                } // time

                                else if (j == internetPayment.length - 1) {
                                    if (internetPayment[j].indexOf(".") != -1) {
                                        sb.insert(0, internetPayment[j]);
                                        enterpriseName = sb.substring(internetPayment[j].indexOf(".") + 1, internetPayment[j].length());
                                        sb.delete(0, sb.length());
                                    }
                                } // enterprise
                            }
                        }// 11번가 등 인터넷 결제 시
                    }// paymentList[i] - internetPayment[j] 비교

                    else if (paymentList[i].indexOf("/") != -1 && paymentList[i].indexOf(":") != -1)
                        time = paymentList[i];
                        // payment Time
                }

                if (time != null && enterpriseName != null && won != null)
                    cardLists.add(new UseCardList(time, enterpriseName, won));
                // time, enterpriseName, won이 null이 아닐 시 값을 넣어줌!

                time = enterpriseName = won = null;
                paymentList = internetPayment = null;
            }
        }
    }

    public void cursorClose(){
        c.close();
    }
    // cursor close
}
