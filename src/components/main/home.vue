<template>
    <div>

        <div>Hello {{ value }}</div>
        <p>Test api connectiong</p>
        <div v-for='company in companies' :key='company.id'>
            <h3>Company Name: </h3>  {{company.name}}
            <h3>Company Address: </h3>  {{company.address}}
        </div>

    </div>

</template>

<script>
export default {
  name: "Home",
  data() {
    return {
        value: "Home"
    }
  },

  computed: {
    companies() {
        return this.$store.state.companies
    }
  },

  mounted() {
      this.$store.dispatch("getCompanies");
  }
};
</script>
