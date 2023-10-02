package com.stevedores.stevedores.service;

import com.Stevedores.Stevedores.StevedoresApplication;
import com.Stevedores.Stevedores.dto.RequestedResource;
import com.Stevedores.Stevedores.dto.ResourceType;
import com.Stevedores.Stevedores.service.ResourceStoreService;
import lombok.extern.slf4j.Slf4j;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.TestInstance;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;

@Slf4j
@TestInstance(TestInstance.Lifecycle.PER_CLASS)
@SpringBootTest(classes = StevedoresApplication.class)
public class ResourceStoreServiceTest {

/*
    @Autowired
    private ResourceStoreService resourceStoreService;

    @Test
    public void testSingleResource(){

        RequestedResource rq = new RequestedResource();

        rq.setPk(1L);
        rq.setAmount(100);
        rq.setType(ResourceType.WATER);



        boolean worked = resourceStoreService.processResourceRequest(rq);

        assertThat(worked).isEqualTo(true);


    }
*/


}
