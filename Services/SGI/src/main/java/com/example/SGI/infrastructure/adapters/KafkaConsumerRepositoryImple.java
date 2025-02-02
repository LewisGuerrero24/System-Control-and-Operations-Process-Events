package com.example.SGI.infrastructure.adapters;

import com.example.SGI.domain.ports.Kafka.KafkaConsumerPorts;
import org.springframework.kafka.annotation.KafkaListener;
import org.springframework.stereotype.Component;

@Component
public class KafkaConsumerRepositoryImple implements KafkaConsumerPorts {


    @Override
    @KafkaListener(topics = "Update-Inventary",groupId = "pos")
    public void listen(String message) {
        try {
            System.out.println("Received message: " + message);
        } catch (Exception e) {
            // Log or handle the error appropriately
            System.err.println("Error processing message: " + e.getMessage());
        }
    }
}
