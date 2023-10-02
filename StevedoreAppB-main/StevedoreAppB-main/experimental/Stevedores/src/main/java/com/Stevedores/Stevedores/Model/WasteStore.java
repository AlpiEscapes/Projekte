package com.Stevedores.Stevedores.Model;


import org.springframework.stereotype.Component;

@Component
public class WasteStore {

    private String wasteStoreLocation;
    private double wasteStoreMax;
    private double wasteStoreAmount;


    public String getWasteStoreLocation() {
        return wasteStoreLocation;
    }

    public void setWasteStoreLocation(String wasteStoreLocation) {
        this.wasteStoreLocation = wasteStoreLocation;
    }

    public double getWasteStoreMax() {
        return wasteStoreMax;
    }

    public void setWasteStoreMax(double wasteStoreMax) {
        this.wasteStoreMax = wasteStoreMax;
    }

    public double getWasteStoreAmount() {
        return wasteStoreAmount;
    }

    public void setWasteStoreAmount(double wasteStoreAmount) {
        this.wasteStoreAmount = wasteStoreAmount;
    }
}
