package com.Stevedores.StevedoresTest.TestController;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

/**
 *
 * @author Sven Reintges
 */
@RestController
public class GreetingsController {
    @RequestMapping(path="/greeting", method=RequestMethod.GET)
    public String getGreeting(){
        return "hello there, im working!";
    }
    @RequestMapping(path="/echo", method=RequestMethod.GET)
    public String echo(String echo){
        return echo;
    }
    
}
