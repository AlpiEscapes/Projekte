package com.Stevedores.Stevedores.dto;

import io.swagger.annotations.ApiModelProperty;

import javax.persistence.*;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.UUID;

@Entity
@Table(name = "pilots")
public class Pilot {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long pk;

    @GeneratedValue(generator = "UUID")
    private UUID uuid = UUID.randomUUID();

    @ElementCollection
    @CollectionTable(name = "allowedTo", joinColumns = @JoinColumn(name = "id"))
    @Enumerated(EnumType.STRING)
    private List<ShipType> allowedTo = new ArrayList();
    private String firstName;
    private String lastName;
    private LocalDate dateOfBirth;

    /* the days and which hours of the day that the pilot works. */
    @Enumerated(EnumType.STRING)
    @OneToMany(cascade = {CascadeType.ALL})
    private Map<DayOfWeek, TimePeriod> workingHours;

    /* the times of day when the pilot is occupied with an order. */
    @ElementCollection
    @ApiModelProperty(hidden = true)
    @Column(columnDefinition = "LONGTEXT")
    private Map<LocalDate, ArrayList<TimePeriod>> occupiedTimes;

    public Pilot() {

    }

    public void setPk(Long id) {
        this.pk = id;
    }

    @Id
    public Long getPk() {
        return pk;
    }
}
