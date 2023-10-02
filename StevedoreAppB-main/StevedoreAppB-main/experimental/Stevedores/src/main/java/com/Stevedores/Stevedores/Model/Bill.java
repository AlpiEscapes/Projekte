package com.Stevedores.Stevedores.Model;


import java.time.LocalDate;


public class Bill {
    private int orderId;
    private String shipName;
    private LocalDate createTime;
    private double totalCost;

    public Bill(int orderId, String shipName, LocalDate createTime, double totalCost) {
        this.orderId = orderId;
        this.shipName = shipName;
        this.createTime = createTime;
        this.totalCost = totalCost;
    }





    public int getOrderId() {
        return orderId;
    }

    public void setOrderId(int orderId) {
        this.orderId = orderId;
    }

    public String getShipName() {
        return shipName;
    }

    public void setShipName(String shipName) {
        this.shipName = shipName;
    }

    public LocalDate getCreateTime() {
        return createTime;
    }

    public void setCreateTime(LocalDate createTime) {
        this.createTime = createTime;
    }

    public double getTotalCost() {
        return totalCost;
    }

    public void setTotalCost(double totalCost) {
        this.totalCost = totalCost;
    }
}
