import Vue from 'vue'
import Vuetify from 'vuetify'
import router from './router'
import store from './store'
import App from './App.vue'
import "../node_modules/vuetify/dist/vuetify.min.css";

Vue.config.productionTip = false
Vue.use(router)
Vue.use(Vuetify)
Vue.use(store)

new Vue({
  el: '#app',
  router,
  store,
  render: h => h(App)
})