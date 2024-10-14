package com.example.SGI.infrastructure.adapters;

import com.example.SGI.domain.models.Customer;
import com.example.SGI.domain.ports.CustomerPorts;
import com.example.SGI.infrastructure.repository.CustomerRepository;

public class CustomerRepositoryImple implements CustomerPorts {

    private final CustomerRepository CustomerJpaRepository;

    public CustomerRepositoryImple(CustomerRepository customerJpaRepository) {
        CustomerJpaRepository = customerJpaRepository;
    }


    @Override
    public Customer findByCustomer(Customer customer) {
        return customer;
    }
}
