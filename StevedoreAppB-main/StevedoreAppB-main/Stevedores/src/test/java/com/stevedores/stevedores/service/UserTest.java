package com.stevedores.stevedores.service;


import com.Stevedores.Stevedores.StevedoresApplication;
import com.Stevedores.Stevedores.dto.User;
import com.Stevedores.Stevedores.service.UserService;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.TestInstance;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

@TestInstance(TestInstance.Lifecycle.PER_CLASS)
@SpringBootTest(classes = StevedoresApplication.class)
public class UserTest {


    @Autowired


    public UserService userService;

    @Test
    public void UserCreateTest() {
        User u = new User();

        u.setPk(123L);

        u.setUsername("svenhacker");
        u.setPassword("password");
        u.setFirstName("sven");
        //u.setLastName("hidden");
        u.setAddress("UK");

        userService.createUser(u);


    }



}
