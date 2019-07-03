<template>
<div>
<h1 class="text-md-center">Welcome {{username}}</h1>
<h1 class="text-md-center">Text {{userString}}</h1>
</div>
</template>

<script>
import axios from 'axios';
import {mapState} from 'vuex';

export default {
    data: () => ({
        
    }),
    computed: {
    username() {
      return this.$store.state.username;
    },

    userString() {
      return this.$store.state.userText;
    },

    quote() {
      var config = {
        headers: {'X-RapidAPI-Host': 'healthruwords.p.rapidapi.comHeader-Value'}

      }
       axios
      .get('https://quotes.rest/qod.json')
      .then(response => {
        console.log(response.data)
      })
      .catch(error => {
        console.log(error)
      })
      .finally(() => this.loading = false)
    }
  }
}

</script>