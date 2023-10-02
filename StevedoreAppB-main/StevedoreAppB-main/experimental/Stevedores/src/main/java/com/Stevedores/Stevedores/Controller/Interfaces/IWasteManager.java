package com.Stevedores.Stevedores.Controller.Interfaces;

public interface IWasteManager {
    public double PercentageFull();
    public boolean IsFull();
    boolean DisposeWaste(double amount);
    public boolean AddWaste(double amount);
    public double GetAvailableStorageSpace();

}
