package com.Stevedores.Stevedores.Controller.Interfaces;

import com.Stevedores.Stevedores.Model.PortServiceOrder.dto.PortServiceOrder;
import com.Stevedores.Stevedores.Model.ReplyMessage;

public interface IUpdateServiceOrder {
    public ReplyMessage postCreateOrder (PortServiceOrder orderRequest, String changeRequesterUuid, String changeReason);
    public ReplyMessage postCancelOrder(String orderUuid, String changeRequestUuid, String changeReason);
    public ReplyMessage postConfirmOrder (String orderUuid, String changeRequesterUuid, String changeReason);
    public ReplyMessage postPlaceExternalOrder(String orderUuid, String changeRequesterUuid, String ChangeReason);
    public ReplyMessage postAddSubOrder (String parentOrderUuid, String childOrderUuid, String changeOrderUuid, String changeReason);
    public ReplyMessage postRemoveSubOrder(String parentOrderUuid, String childOrderUuid, String changeRequesterUuid, String changeReason);
    public ReplyMessage postOrderChangeRequest (PortServiceOrder changeRequest, String changeRequesterUuid, String changeReason);
    public ReplyMessage postAcceptOrRejectOrderChangeRequest(String changeRequestUuid, String responseDescription, boolean acceptOrReject);





}


