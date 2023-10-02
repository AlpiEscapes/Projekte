package com.Stevedores.StevedoresTest;

import com.Stevedores.StevedoresTest.TestController.GreetingsController;
import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;


class StevedoresTestApplicationTests{

	//This echo test will pass everytime
	@Test
	void testEcho() {

		String testString = "Testing works, yay!";
		GreetingsController controller = new GreetingsController();
		assertThat(controller.echo(testString)).isEqualTo(testString);
	}

	//This echo test will always fail
	@Test
	void testEchoFails() {

		String testString = "Testing works, yay!";
		GreetingsController controller = new GreetingsController();
		assertThat(controller.echo(testString)).isEqualTo("this will fail");
	}




}
