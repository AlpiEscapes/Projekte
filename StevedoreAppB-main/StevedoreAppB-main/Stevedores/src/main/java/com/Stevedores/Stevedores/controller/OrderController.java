package com.Stevedores.Stevedores.controller;

import com.Stevedores.Stevedores.dto.Order;
import com.Stevedores.Stevedores.dto.RequestedResource;
import com.Stevedores.Stevedores.dto.ResourceType;
import com.Stevedores.Stevedores.service.OrderService;
import com.Stevedores.Stevedores.service.ResourceStoreService;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.UUID;

@Slf4j
@Api(value="/api/Order",produces="application/json")
@RestController
@RequestMapping("/api/Order")
public class OrderController {

    @Autowired
    private OrderService orderService;

    @Autowired
    private ResourceStoreService resourceStoreService;

    @GetMapping(value = "/{uuid}",produces = "application/json")
    @ApiOperation("Return an order by UUID.")
    public ResponseEntity<Object> findOrderByUUID(@PathVariable UUID uuid){
        Order order = orderService.findByUUID(uuid);
        
        return order != null
                ? new ResponseEntity<>(order, HttpStatus.OK)
                : new ResponseEntity<>(String.format("Order not found: "+uuid),HttpStatus.NOT_FOUND);
    }

    @GetMapping(value = "/test",produces = "application/json")
    @ApiOperation("Return an order by UUID.")
    public boolean test(){

        RequestedResource rq = new RequestedResource();

        rq.setPk(1L);
        rq.setAmount(100);
        rq.setType(ResourceType.WATER);
        log.info("test: "+rq.getType());
        return resourceStoreService.processResourceRequest(rq);
    }

}
