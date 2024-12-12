package com.example.SGI.infrastructure.config;

import com.example.SGI.domain.ports.CustomerPorts;
import com.example.SGI.infrastructure.adapters.CustomerRepositoryImple;
import com.example.SGI.infrastructure.repository.CustomerRepository;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class ConfigRepository {


    @Bean(name = "customCustomerRepository")
    public CustomerPorts customerRepositoryConfig(CustomerRepository jpaCustomerRepository) {
        return new CustomerRepositoryImple(jpaCustomerRepository);
    }

}

