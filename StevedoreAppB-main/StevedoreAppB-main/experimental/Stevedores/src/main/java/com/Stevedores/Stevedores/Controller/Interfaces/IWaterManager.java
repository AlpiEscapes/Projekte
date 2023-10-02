package com.Stevedores.Stevedores.Controller.Interfaces;

public interface IWaterManager {
    public double PercentageFull();
    public boolean IsEmpty();
    public boolean RequestWater(double amount);
    public boolean AddWater(double amount);
    public double GetReserves();

}
