using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        { "modelTopology":{ "class_name":"Sequential","config":{ "name":"sequential_6","layers":[{ "class_name":"Dense","config":{ "units":64,"activation":"relu","use_bias":true,"kernel_initializer":{ "class_name":"VarianceScaling","config":{ "scale":1,"mode":"fan_avg","distribution":"normal","seed":null} },"bias_initializer":{ "class_name":"Zeros","config":{ } },"kernel_regularizer":null,"bias_regularizer":null,"activity_regularizer":null,"kernel_constraint":null,"bias_constraint":null,"name":"dense_Dense16","trainable":true,"batch_input_shape":[null,9],"dtype":"float32"} },{ "class_name":"Dense","config":{ "units":64,"activation":"relu","use_bias":true,"kernel_initializer":{ "class_name":"VarianceScaling","config":{ "scale":1,"mode":"fan_avg","distribution":"normal","seed":null} },"bias_initializer":{ "class_name":"Zeros","config":{ } },"kernel_regularizer":null,"bias_regularizer":null,"activity_regularizer":null,"kernel_constraint":null,"bias_constraint":null,"name":"dense_Dense17","trainable":true} },{ "class_name":"Dense","config":{ "units":9,"activation":"softmax","use_bias":true,"kernel_initializer":{ "class_name":"VarianceScaling","config":{ "scale":1,"mode":"fan_avg","distribution":"normal","seed":null} },"bias_initializer":{ "class_name":"Zeros","config":{ } },"kernel_regularizer":null,"bias_regularizer":null,"activity_regularizer":null,"kernel_constraint":null,"bias_constraint":null,"name":"dense_Dense18","trainable":true} }]},"keras_version":"tfjs-layers 1.7.4","backend":"tensor_flow.js"},"format":"layers-model","generatedBy":"TensorFlow.js tfjs-layers v1.7.4","convertedBy":null,"weightsManifest":[{ "paths":["./ttt_model.weights.bin"],"weights":[{ "name":"dense_Dense16/kernel","shape":[9,64],"dtype":"float32"},{ "name":"dense_Dense16/bias","shape":[64],"dtype":"float32"},{ "name":"dense_Dense17/kernel","shape":[64,64],"dtype":"float32"},{ "name":"dense_Dense17/bias","shape":[64],"dtype":"float32"},{ "name":"dense_Dense18/kernel","shape":[64,9],"dtype":"float32"},{ "name":"dense_Dense18/bias","shape":[9],"dtype":"float32"}]}]}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
