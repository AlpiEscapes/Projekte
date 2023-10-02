package com.stevedores.stevedores.service;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;
import static org.junit.jupiter.api.Assertions.*;

import com.Stevedores.Stevedores.StevedoresApplication;
import com.Stevedores.Stevedores.dto.Order;
import com.Stevedores.Stevedores.dto.OrderStatus;
import com.Stevedores.Stevedores.dto.Pilot;
import com.Stevedores.Stevedores.service.OrderService;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.TestInstance;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

@TestInstance(TestInstance.Lifecycle.PER_CLASS)
@SpringBootTest(classes = StevedoresApplication.class)
public class RestTest {
/*

    @Autowired
    private OrderService orderService;

    @BeforeAll
    public void repositoryCheck(){
        assertNotNull(orderService);
    }

    @Test
    public void orderCrud(){
        //Testing if order can be saved and retrieved
        Order order = new Order();
        Pilot testPilot = new Pilot();

        List<UUID> changeRequests = new ArrayList<UUID>();

        testPilot.setPk(1L);
        order.setChangeRequests(changeRequests);
        order.setPilot(testPilot);
        order.setStatus(OrderStatus.PLACED);
        order.setReason("test");
        order.setPk(1);

        orderService.placeOrder(order);
        Order foundOrder = orderService.findByUUID(order.getUUID());

        assertThat(foundOrder.getUUID()).isEqualTo(order.getUUID());
    }
*/

}
