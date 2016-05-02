package com.example.ss.cardsmspoint;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

/**
 * Created by ss on 2016-04-02.
 */
public class Setting extends MainActivity implements AdapterView.OnItemSelectedListener, ButtonCode{

    private String[] button;
    private int[] cardCopNumber;
    private boolean isViewEnter = false;

    private Intent intent;
    private Spinner[] spinner;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        ArrayAdapter<CharSequence> adapter = ArrayAdapter.createFromResource(this, R.array.planets_array, android.R.layout.simple_spinner_item);
        super.onCreate(savedInstanceState);
        setContentView(R.layout.set_change);
        button = new String[3];
        cardCopNumber = new int[3];
        spinner = new Spinner[3];

        intent = getIntent();

        for(int i=1;i<4;i++){
            button[i-1] = intent.getExtras().getString("btn" + i);
//            cardCopNumber[i-1] = intent.getExtras().getInt("receiveNum" + (i - 1));
        }
        cardCopNumber = intent.getExtras().getIntArray("receiveNum");

        for(int i=0;i<3;i++)
            Log.d("TAG : ", String.valueOf(cardCopNumber[i]));

        spinner[0] = (Spinner)findViewById(R.id.btn1Spinner);
        spinner[1] = (Spinner)findViewById(R.id.btn2Spinner);
        spinner[2] = (Spinner)findViewById(R.id.btn3Spinner);

        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

//        Log.d("TAG : ", String.valueOf(adapter.getCount()));

        for(int i=0;i<spinner.length;i++){
            spinner[i].setOnItemSelectedListener(this);
            spinner[i].setAdapter(adapter);
        }
    }

    @Override
    public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
        if(!isViewEnter){
            String[] value = getResources().getStringArray(R.array.planets_array);

            for(int i=0;i<value.length;i++)
            {
                if(button[0].equals(value[i]))
                    spinner[0].setSelection(i);

                else if(button[1].equals(value[i]))
                    spinner[1].setSelection(i);

                else if(button[2].equals(value[i]))
                    spinner[2].setSelection(i);
            }
            isViewEnter = !isViewEnter;
        }
    }

    @Override
    public void onNothingSelected(AdapterView<?> parent){

    }

    public void defaultBtn(View v){
        int[] defalutSpinnerValue = {1,0,2};

        for(int i=0;i<spinner.length;i++)
            spinner[i].setSelection(defalutSpinnerValue[i]);
    }

    public void setFinish(View v){
        boolean isTrue = false;

        for(int i=0;i<3;i++){
            if(i<2){
                if(spinner[i].getSelectedItem().toString().equals(spinner[i+1].getSelectedItem())){
                    isTrue = true;
                    break;
                }
            }else{
                if(spinner[spinner.length-1].getSelectedItem().toString().equals(spinner[0].getSelectedItem())){
                    isTrue = true;
                    break;
                }
            }
        }

        if(!isTrue){
            for(int i=0;i<3;i++){
                cardCopNumber[i] = (int) spinner[i].getSelectedItemId();
                intent.putExtra("btn"+i, spinner[i].getSelectedItem().toString());
            }

            intent.putExtra("receiveNum", cardCopNumber);

            setResult(SETTING_RESULT, intent);
            isViewEnter = !isViewEnter;
            finish();
        }else{
            AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(this);

            alertDialogBuilder.setTitle("에러");
            alertDialogBuilder.setMessage("버튼을 중복으로 선택하셨습니다.");
            alertDialogBuilder.setCancelable(false);
            alertDialogBuilder.setNegativeButton("확인", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                    dialog.cancel();
                }
            });

            AlertDialog alertDialog = alertDialogBuilder.create();

            alertDialog.show();
        }
    }
}
