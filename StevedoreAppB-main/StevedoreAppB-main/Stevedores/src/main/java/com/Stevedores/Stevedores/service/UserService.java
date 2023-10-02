package com.Stevedores.Stevedores.service;

import com.Stevedores.Stevedores.dao.UserDAO;
import com.Stevedores.Stevedores.dto.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {

    @Autowired
    private UserDAO userDAO;

    public User createUser(User user){


        //returns a message in UserController(api call) if collum is missing
        if(user.getPk()==null || user.getUsername()==null || user.getPassword()==null
                || user.getFirstName()==null|| user.getLastName()==null || user.getAddress()==null)
            return null;



        return userDAO.save(user);
    }
}
