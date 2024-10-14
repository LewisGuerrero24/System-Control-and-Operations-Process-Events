package com.example.SGV.application.services;

import com.example.SGV.application.useCases.CustomerUseCase;
import com.example.SGV.domain.models.Customer;
import com.example.SGV.domain.ports.CustomerPorts;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CustomerServices implements CustomerUseCase {


    private final CustomerPorts customerPorts;

    public CustomerServices(CustomerPorts customerPorts) {
        this.customerPorts = customerPorts;
    }

    @Override
    public Customer findCustomer(Customer customer) {
        return customerPorts.findByCustomer(customer);
    }
}
