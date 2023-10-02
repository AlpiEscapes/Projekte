package com.Stevedores.Stevedores.Model.Ship.dto;

import java.time.LocalDate;

public class ShipReply {
    private String message;
    private LocalDate date;
    private boolean accepted;

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public LocalDate getDate() {
        return date;
    }

    public void setDate(LocalDate date) {
        this.date = date;
    }

    public boolean isAccepted() {
        return accepted;
    }

    public void setAccepted(boolean accepted) {
        this.accepted = accepted;
    }
}
