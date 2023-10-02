package com.Stevedores.Stevedores.repository;

import com.Stevedores.Stevedores.dto.Order;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.UUID;

@Repository
public interface OrderRepository extends JpaRepository<Order,Integer> {
    public Order findOneByUuid(@Param("uuid") UUID uuid);
}
