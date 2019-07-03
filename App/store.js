import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

const state = {
    username: 'User',
    usertext: 'Text'
}

export default new Vuex.Store({state})