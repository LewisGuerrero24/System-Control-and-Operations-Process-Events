package com.example.SGV.infrastructure.config;

import com.example.SGV.domain.ports.CustomerPorts;
import com.example.SGV.infrastructure.adapters.CustomerRepositoryImple;
import com.example.SGV.infrastructure.repository.CustomerRepository;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class ConfigRepository {


    @Bean(name = "customCustomerRepository")
    public CustomerPorts customerRepositoryConfig(CustomerRepository jpaCustomerRepository) {
        return new CustomerRepositoryImple(jpaCustomerRepository);
    }

}
