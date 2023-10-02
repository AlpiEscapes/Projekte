package com.Stevedores.Stevedores.repository;

import com.Stevedores.Stevedores.dto.ResourceStore;
import com.Stevedores.Stevedores.dto.ResourceType;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface ResourceStoreRepository extends JpaRepository<ResourceStore, Integer> {

    @Query(value = "SELECT * FROM resource_store WHERE type = :type AND amount >= :amount", nativeQuery = true)
    public ResourceStore findByTypeAndAmount(@Param("type")ResourceType type, @Param("amount") double amount);
}
