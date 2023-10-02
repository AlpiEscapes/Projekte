package com.Stevedores.Stevedores.Controller;

import com.Stevedores.Stevedores.Controller.Interfaces.IWasteManager;
import com.Stevedores.Stevedores.Model.WasteStore;
import org.springframework.stereotype.Service;

@Service
public class WasteManager implements IWasteManager {
    private WasteStore wasteStore;

    @Override
    public double PercentageFull() {
        return wasteStore.getWasteStoreAmount()/wasteStore.getWasteStoreMax();
    }

    @Override
    public boolean IsFull() {
        return wasteStore.getWasteStoreAmount() == wasteStore.getWasteStoreMax();
    }


    @Override
    public boolean DisposeWaste(double amount) {
        if(wasteStore.getWasteStoreAmount()-amount >= 0){
            wasteStore.setWasteStoreAmount(wasteStore.getWasteStoreAmount()-amount);
            return true;
        }else{
            wasteStore.setWasteStoreAmount(0);
            return false;
        }
    }

    @Override
    public boolean AddWaste(double amount) {
        if(wasteStore.getWasteStoreAmount()+amount <= wasteStore.getWasteStoreMax()){
            wasteStore.setWasteStoreAmount(wasteStore.getWasteStoreAmount()+amount);
            return true;
        }else{
            return false;
        }
    }

    @Override
    public double GetAvailableStorageSpace() {
        return wasteStore.getWasteStoreMax() - wasteStore.getWasteStoreAmount();
    }
}
