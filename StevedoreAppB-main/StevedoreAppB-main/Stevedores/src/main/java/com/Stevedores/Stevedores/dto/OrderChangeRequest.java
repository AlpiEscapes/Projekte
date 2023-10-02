package com.Stevedores.Stevedores.dto;

import javax.persistence.*;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.UUID;

@Entity
public class OrderChangeRequest {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long pk;
    private UUID uuid;
    private UUID parentUUID;

    @Column(name="changeRequestDate", columnDefinition="TIMESTAMP")
    private LocalDateTime changeRequestDate;

    @Column(name="dayOfArrival", columnDefinition="TIMESTAMP")
    private LocalDate dayOfArrival;
    private String reason;
    private OrderChangeRequestStatus status;

    public void setPk(Long id) {
        this.pk = id;
    }

    @Id
    public Long getPk() {
        return pk;
    }

    public UUID getUuid() {
        return uuid;
    }

    public UUID getParentUUID() {
        return parentUUID;
    }

    public void setParentUUID(UUID parentUUID) {
        this.parentUUID = parentUUID;
    }

    public void setUuid(UUID uuid) {
        this.uuid = uuid;
    }

    public LocalDateTime getChangeRequestDate() {
        return changeRequestDate;
    }

    public void setChangeRequestDate(LocalDateTime changeRequestDate) {
        this.changeRequestDate = changeRequestDate;
    }

    public LocalDate getDayOfArrival() {
        return dayOfArrival;
    }

    public void setDayOfArrival(LocalDate dayOfArrival) {
        this.dayOfArrival = dayOfArrival;
    }

    public String getReason() {
        return reason;
    }

    public void setReason(String reason) {
        this.reason = reason;
    }

    public OrderChangeRequestStatus getStatus() {
        return status;
    }

    public void setStatus(OrderChangeRequestStatus status) {
        this.status = status;
    }
}
