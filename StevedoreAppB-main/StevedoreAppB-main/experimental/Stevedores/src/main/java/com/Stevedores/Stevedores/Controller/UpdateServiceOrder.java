/*
package com.Stevedores.Stevedores.Controller;

import com.Stevedores.Stevedores.Controller.Interfaces.IUpdateServiceOrder;
import com.Stevedores.Stevedores.Model.PortServiceOrder.dto.PortServiceOrder;
import com.Stevedores.Stevedores.Model.ReplyMessage;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

*/
/*
This api is used by admins to edit Service Orders
 *//*

@Api(value="/api/admin/EditOrders",produces="application/json")
@RestController
@RequestMapping("/api/admin/EditOrders")
public class UpdateServiceOrder implements IUpdateServiceOrder {

    @ApiOperation(value="create new port service order",response=ReplyMessage.class)
    @RequestMapping(value="/CreateOrder",method = RequestMethod.POST,produces="application/json")
    @Override
    public ReplyMessage postCreateOrder(PortServiceOrder orderRequest, String changeRequesterUuid, String changeReason) {
        return null;
    }

    @ApiOperation(value="cancel port service order",response=ReplyMessage.class)
    @RequestMapping(value="/CancelOrder",method = RequestMethod.DELETE,produces="application/json")
    @Override
    public ReplyMessage postCancelOrder(String orderUuid, String changeRequestUuid, String changeReason) {
        return null;
    }


    @ApiOperation(value="Confirm port service order",response=ReplyMessage.class)
    @RequestMapping(value="/ConfirmOrder",method = RequestMethod.POST,produces="application/json")
    @Override
    public ReplyMessage postConfirmOrder(String orderUuid, String changeRequesterUuid, String changeReason) {
        */
/*
        I am not 100% sure what this method is supposed to do?
        Do all orders need manual administrator confirmation?
        Or is this to confirm an order that was denied by the system manually?
         *//*

        return null;
    }

    @ApiOperation(value="Confirm port service order",response=ReplyMessage.class)
    @RequestMapping(value="/PlaceExternalOrder",method = RequestMethod.POST,produces="application/json")
    @Override
    public ReplyMessage postPlaceExternalOrder(String orderUuid, String changeRequesterUuid, String ChangeReason) {
        return null;
    }

    */
/*
    I am not sure what sub orders are, i will not create the api doc for them for now
     *//*

    @Override
    public ReplyMessage postAddSubOrder(String parentOrderUuid, String childOrderUuid, String changeOrderUuid, String changeReason) {
        return null;
    }

    @Override
    public ReplyMessage postRemoveSubOrder(String parentOrderUuid, String childOrderUuid, String changeRequesterUuid, String changeReason) {
        return null;
    }

    @ApiOperation(value="create new request to change an order port service order",response=ReplyMessage.class)
    @RequestMapping(value="/OrderChangeRequest",method = RequestMethod.PUT,produces="application/json")
    @Override
    public ReplyMessage postOrderChangeRequest(PortServiceOrder changeRequest, String changeRequesterUuid, String changeReason) {
        return null;
    }

    @ApiOperation(value="Accept or reject a change request",response=ReplyMessage.class)
    @RequestMapping(value="/AcceptOrRejectOrderChangeRequest",method = RequestMethod.POST,produces="application/json")
    @Override
    public ReplyMessage postAcceptOrRejectOrderChangeRequest(String changeRequestUuid, String responseDescription, boolean acceptOrReject) {
        return null;
    }

}
*/
