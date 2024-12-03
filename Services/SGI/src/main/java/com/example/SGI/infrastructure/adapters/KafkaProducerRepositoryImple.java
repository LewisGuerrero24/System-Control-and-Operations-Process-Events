package com.example.SGI.infrastructure.adapters;

import com.example.SGI.domain.ports.Kafka.KafkaProducerPorts;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.kafka.core.KafkaTemplate;
import org.springframework.stereotype.Component;

@Component
public class KafkaProducerRepositoryImple implements KafkaProducerPorts {

    @Autowired
    private KafkaTemplate<String, String> kafkaTemplate;


    @Override
    public void kafkaProducerMessages(String topic, String messages) {
        kafkaTemplate.send(topic,messages);
    }
}
