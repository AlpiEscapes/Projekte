package com.Stevedores.Stevedores.dao;

import com.Stevedores.Stevedores.dto.User;
import com.Stevedores.Stevedores.repository.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

@Repository
public class UserDAO {

    @Autowired
    private UserRepository userRepository;

    public User save(User user){
        return userRepository.save(user);
    }
}
