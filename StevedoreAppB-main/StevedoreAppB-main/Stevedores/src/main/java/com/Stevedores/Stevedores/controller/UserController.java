package com.Stevedores.Stevedores.controller;

import com.Stevedores.Stevedores.dto.User;
import com.Stevedores.Stevedores.service.UserService;
import io.swagger.annotations.Api;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@Api(value="/api/User",produces="application/json")
@RestController
@RequestMapping("/api/User")
public class UserController {

    @Autowired
    private UserService userService;
    
    @PostMapping(value="/addUser", produces="application/json")
    public ResponseEntity<Object> addUser(@RequestBody User user){
        User userRet = userService.createUser(user);

        return userRet != null
                ? new ResponseEntity<>(userRet, HttpStatus.OK)
                : new ResponseEntity<>(String.format("User not added"),HttpStatus.FORBIDDEN);



    }
    

}
