package com.Stevedores.Stevedores.Controller;

import com.Stevedores.Stevedores.Controller.Interfaces.IWaterManager;
import com.Stevedores.Stevedores.Model.WaterStore;
import org.springframework.stereotype.Service;

@Service
public class WaterManager implements IWaterManager {

    private WaterStore waterStore;

    public WaterManager(WaterStore waterStore){
        this.waterStore = waterStore;
    }

    @Override
    public double PercentageFull() {
        return waterStore.getWaterStoreReserves()/waterStore.getWaterStoreMax();
    }

    @Override
    public boolean IsEmpty() {
        return waterStore.getWaterStoreReserves() == 0;
    }

    @Override
    public boolean RequestWater(double amount) {
        if(waterStore.getWaterStoreReserves()- amount >=0){
            waterStore.setWaterStoreReserves(waterStore.getWaterStoreReserves()-amount);
            return true;
        }else{
            return false;
        }
    }

    @Override
    public boolean AddWater(double amount) {
        if(waterStore.getWaterStoreReserves()+amount <= waterStore.getWaterStoreMax()){
            waterStore.setWaterStoreReserves(waterStore.getWaterStoreReserves()+amount);
            return true;
        }else{
            return false;
        }
    }

    @Override
    public double GetReserves() {
        return waterStore.getWaterStoreReserves();
    }
}
