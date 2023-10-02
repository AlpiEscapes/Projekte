/*
package com.Stevedores.Stevedores.Controller;

import com.Stevedores.Stevedores.Controller.Interfaces.IBillingManager;
import com.Stevedores.Stevedores.Model.Bill;
import com.Stevedores.Stevedores.Model.PortServiceOrder.dto.PortServiceOrder;
import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import java.time.LocalDate;
import java.util.ArrayList;


@Api(value="/api/BillingManager",produces="application/json")
@RestController
@RequestMapping("/api/BillingManager")
public class BillingManager implements IBillingManager {

    public ArrayList<Bill> getBills() {
        return bills;
    }

    public void setBills(ArrayList<Bill> bills) {
        this.bills = bills;
    }

    private ArrayList<Bill> bills = new ArrayList<>();

    public BillingManager() {

    }

    private double CalculateC(PortServiceOrder order){

        double tmp = 0;
        for(int i = 0; i<order.getRequestedResources().size(); i++){
            for(int j = 0; j<order.getRequestedResources().get(0).getCharacteristics().size(); j++) {
                tmp += order.getRequestedResources().get(i).getCharacteristics().get(j).getValue();
            }
        }
        return tmp;
    }

    @ApiOperation(value="create new bill",response=Double.class)
    @RequestMapping(value="/CreateBill",method = RequestMethod.POST,produces="application/json")
    @Override
    public Bill CreateBill(PortServiceOrder order) {

        double tmp = CalculateC(order);
        Bill b = new Bill( 100, "bigship", LocalDate.now() , tmp);

        this.getBills().add(b);

        return b;
    }

    @ApiOperation(value="calculate cost",response=Double.class)
    @RequestMapping(value="/CalculateCost",method = RequestMethod.POST,produces="application/json")
    @Override
    public double CalculateCost(PortServiceOrder order) {
        double tmp = CalculateC(order);

        return tmp;
    }
}
*/
