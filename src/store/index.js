import axios from 'axios'
import Vuex from 'vuex'
import Vue from 'vue'

Vue.use(Vuex);

const state = {
    companies: []
}


const getters = {}


const actions = {
    getCompanies({ commit }) {
        axios.get('https://webapi20210720.azurewebsites.net/api/companies')
            .then(response => {
                commit('SET_COMPANIES', response.data)
            })
    }

}


const mutations = {
    SET_COMPANIES(state, companies) {
        state.companies = companies
    }
}


export default new Vuex.Store({
    state,
    getters,
    actions,
    mutations
})