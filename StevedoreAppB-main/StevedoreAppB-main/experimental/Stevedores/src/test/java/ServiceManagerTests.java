/*
import com.Stevedores.Stevedores.Controller.ServiceManager;
import com.Stevedores.Stevedores.Controller.WasteManager;
import com.Stevedores.Stevedores.Controller.WaterManager;
import com.Stevedores.Stevedores.Model.WaterStore;
import org.junit.jupiter.api.Test;
import org.springframework.util.Assert;
import static org.assertj.core.api.AssertionsForClassTypes.assertThat;
public class ServiceManagerTests {


    @Test
    public void ProvisionFromFullStorage(){
        ServiceManager serviceManager = new ServiceManager(new WasteManager(),new WaterManager(new WaterStore()));
        boolean actual = serviceManager.ProvisionWaterToShip(1,"testship",200);
        boolean expected = true;

        assertThat(actual).isEqualTo(expected);
    }

    @Test
    public void ProvisionFromEmptyStorage(){
        ServiceManager serviceManager = new ServiceManager(new WasteManager(),new WaterManager(new WaterStore("test",100,1000)));
        boolean actual = serviceManager.ProvisionWaterToShip(1,"testship",200);
        boolean expected = false;

        assertThat(actual).isEqualTo(expected);
    }
}
*/
