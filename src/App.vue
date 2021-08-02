<template>
    <div class="container">
        <appHeader></appHeader>
        <div class="row">
            <div class="col-xs-12">
                <router-view></router-view>
            </div>
        </div>
</div>
  
</template>

<script>
import Header from './components/header.vue'

export default {
    name: "App",
    components: {
         appHeader :Header
    }
 
};
</script>
