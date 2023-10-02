package com.Stevedores.Stevedores.dao;

import com.Stevedores.Stevedores.dto.Order;
import com.Stevedores.Stevedores.dto.ResourceStore;
import com.Stevedores.Stevedores.dto.ResourceType;
import com.Stevedores.Stevedores.repository.ResourceStoreRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class ResourceStoreDAO {

    @Autowired
    private ResourceStoreRepository resourceStoreRepository;

    public List<ResourceStore> findAll(){
        return resourceStoreRepository.findAll();
    }

    public ResourceStore findByTypeAndAmount(ResourceType type, double amount){
        return resourceStoreRepository.findByTypeAndAmount(type,amount);
    }

    public void save(ResourceStore stores){
        resourceStoreRepository.save(stores);
    }

}
