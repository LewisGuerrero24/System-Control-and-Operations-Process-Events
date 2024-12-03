package com.example.SGI.application.services;

import com.example.SGI.application.useCases.Kafka.KafkaUseCase;
import com.example.SGI.domain.ports.Kafka.KafkaConsumerPorts;
import com.example.SGI.domain.ports.Kafka.KafkaProducerPorts;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class KafkaServices implements KafkaUseCase {
    @Autowired
    private KafkaConsumerPorts consumerPorts;

    @Autowired
    private KafkaProducerPorts producerPorts;

    @Override
    public void kafkaSendMessage(String topic, String Messages) {
        producerPorts.kafkaProducerMessages(topic,Messages);
    }

    @Override
    public void listenMessages(String message) {
        consumerPorts.listen(message);
    }
}
