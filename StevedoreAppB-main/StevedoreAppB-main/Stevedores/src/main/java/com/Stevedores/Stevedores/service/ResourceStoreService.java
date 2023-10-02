package com.Stevedores.Stevedores.service;

import com.Stevedores.Stevedores.dao.ResourceStoreDAO;
import com.Stevedores.Stevedores.dto.RequestedResource;
import com.Stevedores.Stevedores.dto.ResourceStore;
import com.Stevedores.Stevedores.dto.ResourceType;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Slf4j
@Service
public class ResourceStoreService {
    @Autowired
    private ResourceStoreDAO resourceStoreDAO;


    public boolean processResourceRequest(RequestedResource r){
        ResourceStore resourceStore = resourceStoreDAO.findByTypeAndAmount(r.getType(),r.getAmount());


        if(resourceStore != null){
            resourceStore.setAmount(resourceStore.getAmount()-r.getAmount());
            resourceStoreDAO.save(resourceStore);
            return true;
       }else {
            return false;
       }
    }

    public boolean processMultipleResourceRequests(List<RequestedResource> r){


        double waterAmount = 0;
        double wasteAmount = 0;
        double cargoAmount = 0;
        double foodAmount = 0;


        for (RequestedResource resource:r) {
            switch (resource.getType()){
                case WATER: waterAmount+=resource.getAmount(); break;
                case WASTE: wasteAmount+=resource.getAmount(); break;
                case CARGO: cargoAmount+=resource.getAmount(); break;
                case FOOD: foodAmount+=resource.getAmount(); break;
            }
        }

        ResourceStore waterStore = resourceStoreDAO.findByTypeAndAmount(ResourceType.WATER,waterAmount);
        ResourceStore wasteStore = resourceStoreDAO.findByTypeAndAmount(ResourceType.WASTE,wasteAmount);
        ResourceStore foodStore = resourceStoreDAO.findByTypeAndAmount(ResourceType.CARGO,cargoAmount);
        ResourceStore cargoStore = resourceStoreDAO.findByTypeAndAmount(ResourceType.FOOD,foodAmount);

        if(waterStore != null && wasteStore != null && foodStore != null && cargoStore != null){
            for (RequestedResource resource: r) {
                processResourceRequest(resource);
            }
        }else {
            return false;
        }

        return true;

    }
}
