package com.Stevedores.Stevedores.Model;


import org.springframework.context.annotation.Bean;
import org.springframework.stereotype.Component;

@Component
public class WaterStore {
    private Long id;
    private String waterStoreLocation;
    private double waterStoreReserves;

    public WaterStore(String waterStoreLocation, double waterStoreReserves, double waterStoreMax) {
        this.waterStoreLocation = waterStoreLocation;
        this.waterStoreReserves = waterStoreReserves;
        this.waterStoreMax = waterStoreMax;
    }

    public WaterStore() {
        this.waterStoreLocation = "TestLocation";
        this.waterStoreReserves = 1000;
        this.waterStoreMax = 1000;
    }

    private double waterStoreMax;



    public String getWaterStoreLocation() {
        return waterStoreLocation;
    }

    public void setWaterStoreLocation(String waterStoreLocation) {
        this.waterStoreLocation = waterStoreLocation;
    }

    public double getWaterStoreReserves() {
        return waterStoreReserves;
    }

    public void setWaterStoreReserves(double waterStoreReserves) {
        this.waterStoreReserves = waterStoreReserves;
    }

    public double getWaterStoreMax() {
        return waterStoreMax;
    }

    public void setWaterStoreMax(double waterStoreMax) {
        this.waterStoreMax = waterStoreMax;
    }
}

