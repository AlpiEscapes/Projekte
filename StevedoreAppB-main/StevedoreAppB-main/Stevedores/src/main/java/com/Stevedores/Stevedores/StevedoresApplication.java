package com.Stevedores.Stevedores;

import com.Stevedores.Stevedores.dto.RequestedResource;
import com.Stevedores.Stevedores.dto.ResourceType;
import com.Stevedores.Stevedores.service.ResourceStoreService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Import;
import springfox.bean.validators.configuration.BeanValidatorPluginsConfiguration;
import springfox.documentation.swagger2.annotations.EnableSwagger2;

@Configuration
@SpringBootApplication
@EnableSwagger2
@Import(BeanValidatorPluginsConfiguration.class)
public class StevedoresApplication {


    public static void main(String[] args) {

        SpringApplication.run(StevedoresApplication.class, args);





    }

}
