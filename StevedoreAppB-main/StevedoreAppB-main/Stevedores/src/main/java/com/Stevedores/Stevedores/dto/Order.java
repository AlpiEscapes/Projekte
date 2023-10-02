package com.Stevedores.Stevedores.dto;


import io.swagger.annotations.ApiModelProperty;


import javax.persistence.*;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.List;
import java.util.UUID;

@Entity
@Table(name="orders")
public class Order {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @ApiModelProperty(hidden = true)
    private int pk;

    @GeneratedValue(generator = "UUID")
    private UUID uuid;


    private OrderStatus status;

    private String reason;

    private double fare;

    @Column(name="orderDate", columnDefinition="TIMESTAMP")
    private LocalDateTime orderDate;

    @Column(name="dayOfArrival", columnDefinition="TIMESTAMP")
    private LocalDate dayOfArrival;

    @Column(name="allocatedStart", columnDefinition="TIMESTAMP")
    private LocalDateTime allocatedStart;

    @Column(name="allocatedEnd", columnDefinition="TIMESTAMP")
    private LocalDateTime allocatedEnd;

    @ElementCollection
    private List<UUID> changeRequests;

    @OneToMany
    private List<RequestedResource> resources;

    @OneToOne(cascade = {CascadeType.ALL})
    private Ship ship;

    @OneToOne(cascade = {CascadeType.ALL})
    private Pilot pilot;

    @OneToOne(cascade = {CascadeType.ALL})
    private Berth berth;

    @Transient
    private final double[] fares = { 311.85, 589.23, 189.32 };

    public Order() {

    }

    public int getPk() {
        return pk;
    }

    public void setPk(int pk) {
        this.pk = pk;
    }

    public UUID getUUID() {
        return uuid;
    }

    public void setUUID(UUID uuid) {
        this.uuid = uuid;
    }

    public Ship getShip() {
        return ship;
    }

    public void setShip(Ship ship) {
        this.ship = ship;
    }

    public Pilot getPilot() {
        return pilot;
    }

    public void setPilot(Pilot pilot) {
        this.pilot = pilot;
    }

    public LocalDate getDayOfArrival() {
        return dayOfArrival;
    }

    public void setDayOfArrival(LocalDate dayOfArrival) {
        this.dayOfArrival = dayOfArrival;
    }

    public LocalDateTime getOrderDate() {
        return orderDate;
    }

    public void setOrderDate(LocalDateTime orderDate) {
        this.orderDate = orderDate;
    }

    public LocalDateTime getAllocatedStart() {
        return allocatedStart;
    }

    public void setAllocatedStart(LocalDateTime allocatedStart) {
        this.allocatedStart = allocatedStart;
    }

    public LocalDateTime getAllocatedEnd() {
        return allocatedEnd;
    }

    public void setAllocatedEnd(LocalDateTime allocatedEnd) {
        this.allocatedEnd = allocatedEnd;
    }

    public List<UUID> getChangeRequests() {
        return changeRequests;
    }

    public void setChangeRequests(List<UUID> changeRequests) {
        this.changeRequests = changeRequests;
    }

    public Berth getBerth() {
        return berth;
    }

    public void setBerth(Berth berth) {
        this.berth = berth;
    }

    public OrderStatus getStatus() {
        return status;
    }

    public void setStatus(OrderStatus status) {
        this.status = status;
    }

    public String getReason() {
        return reason;
    }

    public void setReason(String reason) {
        this.reason = reason;
    }

    public double getFare() {
        return fare;
    }

    public void setFare(double fare) {
        this.fare = fare;
    }

}
