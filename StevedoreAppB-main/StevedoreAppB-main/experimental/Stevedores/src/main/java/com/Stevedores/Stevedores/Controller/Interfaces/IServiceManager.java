package com.Stevedores.Stevedores.Controller.Interfaces;

public interface IServiceManager {
    boolean ProvisionWaterToShip(int orderId, String shipName, double amount);
    boolean RemoveWasteFromShip(int orderId, String shipName, double amount);
    boolean OffloadCargoFromShip(int orderId, String shipName);
    boolean OnloadCargoToShip(int orderId, String shipName);
}