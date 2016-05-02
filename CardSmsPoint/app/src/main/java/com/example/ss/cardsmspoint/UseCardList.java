package com.example.ss.cardsmspoint;

/**
 * Created by ss on 2015-11-17.
 */
public class UseCardList {

    private String paymentTime;
    private String enterpriseName;
    private String price;

    public UseCardList(String paymentTime, String enterpriseName, String price)
    {
        this.paymentTime = paymentTime;
        this.enterpriseName = enterpriseName;
        this.price = price;
    }

    public String getPaymenTime(){
        return paymentTime;
    }

    public String getEnterpriseName(){
        return enterpriseName;
    }

    public String getPrice(){ return price; }
}