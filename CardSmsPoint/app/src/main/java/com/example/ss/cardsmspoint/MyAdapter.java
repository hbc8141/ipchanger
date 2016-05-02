package com.example.ss.cardsmspoint;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.Locale;

/**
 * Created by ss on 2015-11-17.
 */
public class MyAdapter extends BaseAdapter {
    private Context context;
    private int item_layout;
    private ArrayList<UseCardList> cardLists;
    private ArrayList<UseCardList> list = null;
    private LayoutInflater inflater;
    private TextView lblTime, lblContent, lblprice;

    public MyAdapter(Context context, int item_layout, ArrayList<UseCardList> cardLists) {
        this.context = context;
        this.item_layout = item_layout;
        this.cardLists = cardLists;
        list = new ArrayList<UseCardList>();
        list.addAll(cardLists);
        inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
    }

    @Override
    public int getCount() {
        return cardLists.size();
    }

    @Override
    public Object getItem(int position) {
        return cardLists.get(position);
    }

    @Override
    public long getItemId(int position) {
        return position;
    }

    @Override
    public View getView(final int position, View convertView, ViewGroup parent) {
        final int index = position;
        if(convertView==null)
            convertView = inflater.inflate(item_layout, null);

        lblTime = (TextView)convertView.findViewById(R.id.lblTime);
        lblTime.setText(cardLists.get(position).getPaymenTime());

        lblContent = (TextView)convertView.findViewById(R.id.lblMsg);
        lblContent.setText(cardLists.get(position).getEnterpriseName());

        lblprice = (TextView) convertView.findViewById(R.id.lblPrice);
        lblprice.setText(cardLists.get(position).getPrice());

        return convertView;
    }

    public void addList(ArrayList<UseCardList> arrayList){
        list.addAll(arrayList);
        notifyDataSetChanged();
    }

    public void removeList(){
        list.clear();
        notifyDataSetChanged();
    }

    public void filter(String charText){
        charText = charText.toLowerCase(Locale.getDefault());
        //list = cardLists;
        cardLists.clear();

        if(charText.length()==0)
            cardLists.addAll(list);

        else {
            for (UseCardList cl : list)
                if (cl.getEnterpriseName().toLowerCase(Locale.getDefault()).contains(charText))
                    cardLists.add(cl);
        }

        notifyDataSetChanged();
    }
}