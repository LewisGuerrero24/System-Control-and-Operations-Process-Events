package com.example.SGV.infrastructure.adapters;

import com.example.SGV.domain.models.Customer;
import com.example.SGV.domain.ports.CustomerPorts;
import com.example.SGV.infrastructure.repository.CustomerRepository;

public class CustomerRepositoryImple implements CustomerPorts {

    private final CustomerRepository customerJpaRepository;

    public CustomerRepositoryImple(CustomerRepository customerJpaRepository) {
        this.customerJpaRepository = customerJpaRepository;
    }


    @Override
    public Customer findByCustomer(Customer customer) {
        return customer;
    }
}
