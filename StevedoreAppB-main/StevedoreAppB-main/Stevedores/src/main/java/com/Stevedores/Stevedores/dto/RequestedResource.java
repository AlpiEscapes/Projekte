package com.Stevedores.Stevedores.dto;

import io.swagger.annotations.ApiModelProperty;

import javax.persistence.*;

@Entity
//@Table(name = "RequestedResources")
public class RequestedResource {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @ApiModelProperty(hidden = true)
    private Long pk;

    private double amount;
    private ResourceType type;

    public double getAmount() {
        return amount;
    }

    public void setAmount(double amount) {
        this.amount = amount;
    }

    public ResourceType getType() {
        return type;
    }

    public void setType(ResourceType type) {
        this.type = type;
    }

    public void setPk(Long pk) {
        this.pk = pk;
    }

    @Id
    public Long getPk() {
        return pk;
    }
}
