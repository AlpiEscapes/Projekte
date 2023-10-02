package com.Stevedores.Stevedores.dto;

import io.swagger.annotations.ApiModelProperty;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.io.Serializable;
import java.time.LocalTime;

@Entity
public class TimePeriod implements Serializable {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @ApiModelProperty(hidden = true)
    private int pk;

    private LocalTime start;
    private LocalTime end;

    public TimePeriod() {

    }


    public int getPk() {
        return pk;
    }

    public void setPk(int id) {
        this.pk = id;
    }

    public LocalTime getStart() {
        return start;
    }

    public void setStart(LocalTime start) {
        this.start = start;
    }

    public LocalTime getEnd() {
        return end;
    }

    public void setEnd(LocalTime end) {
        this.end = end;
    }

    @Override
    public String toString() {
        return this.getClass().getSimpleName() + "[pk=" + pk + ", start=" + start + ", end=" + end + "]";
    }
}
