package com.example.SGI.application.useCases.Kafka;

public interface KafkaUseCase {

    void kafkaSendMessage(String topic, String Messages );

    void listenMessages(String message);
}
