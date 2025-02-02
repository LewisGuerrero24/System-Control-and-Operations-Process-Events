package com.example.SFF.infrastructure.config;

import com.example.SFF.domain.ports.CustomerPorts;
import com.example.SFF.infrastructure.adapters.CustomerRepositoryImple;
import com.example.SFF.infrastructure.repository.CustomerRepository;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class ConfigRepository {


    @Bean(name = "customCustomerRepository")
    public CustomerPorts customerRepositoryConfig(CustomerRepository jpaCustomerRepository) {
        return new CustomerRepositoryImple(jpaCustomerRepository);
    }

}

