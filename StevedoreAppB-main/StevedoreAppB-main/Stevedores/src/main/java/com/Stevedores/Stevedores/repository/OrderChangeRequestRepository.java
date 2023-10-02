package com.Stevedores.Stevedores.repository;

import com.Stevedores.Stevedores.dto.OrderChangeRequest;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface OrderChangeRequestRepository extends JpaRepository<OrderChangeRequest, Integer> {

}
