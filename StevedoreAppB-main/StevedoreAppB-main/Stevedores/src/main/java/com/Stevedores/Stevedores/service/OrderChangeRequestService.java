package com.Stevedores.Stevedores.service;

import com.Stevedores.Stevedores.dao.OrderChangeRequestDAO;
import com.Stevedores.Stevedores.dto.OrderChangeRequest;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class OrderChangeRequestService {
    @Autowired
    private OrderChangeRequestDAO orderChangeRequestDAO;

    public OrderChangeRequest placeOrderChangeRequest(){
        OrderChangeRequest ocr = new OrderChangeRequest();
        ocr.setPk(123L);
        ocr.setReason("test");
        orderChangeRequestDAO.save(ocr);
        return ocr;
    }
}
