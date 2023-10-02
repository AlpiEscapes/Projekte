package com.Stevedores.Stevedores.Model.PortServiceOrder.dto;

import com.Stevedores.Stevedores.Model.PortServiceOrder.dto.ChangeStatus;
import com.Stevedores.Stevedores.Model.PortServiceOrder.dto.PortServiceOrder;

import java.time.LocalDate;


public class OrderChangeRequest {
    private String uuid;
    private String href;
    private PortServiceOrder changeRequest;
    private LocalDate requestDate;
    private LocalDate approvedDate;
    private ChangeStatus status;
    private String changeReason;
    //TODO add party
    private String responseDescription;




    public String getUuid() {
        return uuid;
    }

    public void setUuid(String uuid) {
        this.uuid = uuid;
    }

    public String getHref() {
        return href;
    }

    public void setHref(String href) {
        this.href = href;
    }


    public void setChangeRequest(PortServiceOrder changeRequest) {
        this.changeRequest = changeRequest;
    }

    public LocalDate getRequestDate() {
        return requestDate;
    }

    public void setRequestDate(LocalDate requestDate) {
        this.requestDate = requestDate;
    }

    public LocalDate getApprovedDate() {
        return approvedDate;
    }

    public void setApprovedDate(LocalDate approvedDate) {
        this.approvedDate = approvedDate;
    }

    public ChangeStatus getStatus() {
        return status;
    }

    public void setStatus(ChangeStatus status) {
        this.status = status;
    }

    public String getChangeReason() {
        return changeReason;
    }

    public void setChangeReason(String changeReason) {
        this.changeReason = changeReason;
    }

    public String getResponseDescription() {
        return responseDescription;
    }

    public void setResponseDescription(String responseDescription) {
        this.responseDescription = responseDescription;
    }
}
