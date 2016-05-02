package com.example.ss.cardsmspoint;


import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.MotionEvent;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.Locale;

public class MainActivity extends Activity implements ButtonCode {

    private ArrayList<UseCardList> cardLists;
    private ListView lvMsg;
    private MyAdapter adapter;
    private String[] receiveNumber = {"15881788", "15881600", "15884000", "15449000"}; // KB, NongHyup, Busan, woori
    private InputMethodManager imm;

    private SmsInbox inbox;

    private Button btn1, btn2, btn3;
    private EditText editSearch;
    private int[] smsInboxNum = {1, 0, 2};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        initialization();
    }

    private void initialization(){
        btn1 = (Button)findViewById(R.id.btn1);
        btn2 = (Button)findViewById(R.id.btn2);
        btn3 = (Button)findViewById(R.id.btn3);
        lvMsg = (ListView) findViewById(R.id.lvMsg);
        editSearch = (EditText)findViewById(R.id.search);

        cardLists = new ArrayList<UseCardList>();
        adapter = new MyAdapter(getApplicationContext(), R.layout.row, cardLists);

        inbox = new SmsInbox();

        imm = (InputMethodManager)getSystemService(Context.INPUT_METHOD_SERVICE);

        setListener();

        editSearch.setCursorVisible(false);
    } // initialize

    private void setListener(){
        btn1.setOnClickListener(mOnClickListener);
        btn2.setOnClickListener(mOnClickListener);
        btn3.setOnClickListener(mOnClickListener);

        lvMsg.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                resignKeyboard();
                editSearch.setCursorVisible(false);
                return false;
            }
        });

        editSearch.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {
            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
            }

            @Override
            public void afterTextChanged(Editable s) {
                String text = editSearch.getText().toString().toLowerCase(Locale.getDefault());
                adapter.filter(text);
            }
        });

        editSearch.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                editSearch.setCursorVisible(true);
            }
        });
    }

    Button.OnClickListener mOnClickListener = new View.OnClickListener(){
        public void onClick(View v){
            if(!editSearch.getText().toString().equals(""))
                editSearch.setText("");

            resignKeyboard();
            adapter.removeList();

            switch (v.getId()){
                case R.id.btn1:
                    inbox(receiveNumber[smsInboxNum[0]]);
                    break;
                case R.id.btn2:
                    inbox(receiveNumber[smsInboxNum[1]]);
                    break;
                case R.id.btn3:
                    inbox(receiveNumber[smsInboxNum[2]]);
                    break;
            }
        }
    }; // button click event

    private void resignKeyboard(){
        imm.hideSoftInputFromWindow(editSearch.getWindowToken(), 0);
        editSearch.setCursorVisible(false);
    } // hide keyboard

    public void setting(View v){
        Intent intent = new Intent(this, Setting.class);
        intent.putExtra("btn1", btn1.getText().toString());
        intent.putExtra("btn2", btn2.getText().toString());
        intent.putExtra("btn3", btn3.getText().toString());

        intent.putExtra("receiveNum", smsInboxNum);

        startActivityForResult(intent, SETTING);

        cardLists.clear();
        adapter.notifyDataSetChanged();
    } // button setting

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        if(requestCode == SETTING){
            switch (resultCode){
                case SETTING_RESULT:
                    String value[] = new String[3];
                    for(int i=0;i<value.length;i++)
                        value[i] = data.getExtras().getString("btn" + i);

                    smsInboxNum = data.getExtras().getIntArray("receiveNum");

                    btn1.setText(value[0]);
                    btn2.setText(value[1]);
                    btn3.setText(value[2]);
                    break;
            }
        }
    } // setting result

    public void inbox(String receiveNumber)
    {
        inbox.inbox(this, receiveNumber, cardLists);
        lvMsg.setAdapter(adapter);
        adapter.addList(cardLists);
        inbox.cursorClose();
    } // sms parser

    public void btn1CardList(View v) {
        inbox(receiveNumber[smsInboxNum[0]]);
    }
    // button 1

    public void btn2CardList(View v){
        inbox(receiveNumber[smsInboxNum[1]]);
    }
    // button 2

    public void btn3CardList(View v) {
        inbox(receiveNumber[smsInboxNum[2]]);
    }
    // button 3

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);

//        Button btn = (Button)findViewById(R.id.action_settings);
        MenuItem item = (MenuItem)findViewById(R.id.action_settings);

        findViewById(R.id.action_settings).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), Setting.class);
                intent.putExtra("btn1", btn1.getText().toString());
                intent.putExtra("btn2", btn2.getText().toString());
                intent.putExtra("btn3", btn3.getText().toString());

                intent.putExtra("receiveNum", smsInboxNum);

                startActivityForResult(intent, SETTING);

                cardLists.clear();
                adapter.notifyDataSetChanged();
            }
        });

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        Log.d("TAG : ", "TEst");
        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}