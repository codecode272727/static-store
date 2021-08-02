import Vue from 'vue'
import App from './App.vue'
import store from './store'
import VueRouter from 'vue-router'
import { routes } from './routes'
import BootstrapVue from 'bootstrap-vue/dist/bootstrap-vue.esm';
import 'bootstrap-vue/dist/bootstrap-vue.css';
import 'bootstrap/dist/css/bootstrap.css';

Vue.use(BootstrapVue);
Vue.config.productionTip = false
Vue.use(VueRouter);


const router = new VueRouter({
    mode: 'history',
    routes
});

new Vue({
  router,
  store,
  render: h => h(App),
}).$mount('#app')
