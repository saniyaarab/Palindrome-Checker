import Vue from 'vue'
import VueRouter from 'vue-router'
import Login from './Components/Login.vue'
import Welcome from './Components/Welcome.vue'
import Start from './Components/Start.vue'


Vue.config.productionTip = false
Vue.use(VueRouter)

const routes = [
    { 
      path: '/', 
      component: Start
    },
    {
      path:'/Welcome',
      component: Welcome
    }
  ]

export default new VueRouter({mode: 'history', routes})