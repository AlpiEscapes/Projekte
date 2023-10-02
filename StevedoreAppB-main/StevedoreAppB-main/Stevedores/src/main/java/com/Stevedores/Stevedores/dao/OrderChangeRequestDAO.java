package com.Stevedores.Stevedores.dao;

import com.Stevedores.Stevedores.dto.OrderChangeRequest;
import com.Stevedores.Stevedores.repository.OrderChangeRequestRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

@Repository
public class OrderChangeRequestDAO {
    @Autowired
    private OrderChangeRequestRepository orderChangeRequestRepository;
    public OrderChangeRequest save(OrderChangeRequest ocr) {
        return orderChangeRequestRepository.save(ocr);
    }
}
