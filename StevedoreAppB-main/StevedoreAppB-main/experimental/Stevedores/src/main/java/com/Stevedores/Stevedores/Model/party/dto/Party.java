package com.Stevedores.Stevedores.Model.party.dto;


import com.Stevedores.Stevedores.Model.User.dto.User;

import java.util.Set;

public class Party {

    private String href;
    private String name;
    private PartyRoll partyRoll;
    private Address address;
    private PartyStatus partyStatus;
    private Set<User> users;

    public String getHref() {
        return href;
    }

    public void setHref(String href) {
        this.href = href;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public PartyRoll getPartyRoll() {
        return partyRoll;
    }

    public void setPartyRoll(PartyRoll partyRoll) {
        this.partyRoll = partyRoll;
    }

    public Address getAddress() {
        return address;
    }

    public void setAddress(Address address) {
        this.address = address;
    }

    public PartyStatus getPartyStatus() {
        return partyStatus;
    }

    public void setPartyStatus(PartyStatus partyStatus) {
        this.partyStatus = partyStatus;
    }

    public Set<User> getUsers() {
        return users;
    }

    public void setUsers(Set<User> users) {
        this.users = users;
    }






}
