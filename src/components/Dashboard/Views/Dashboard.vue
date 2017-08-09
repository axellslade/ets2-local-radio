<template>
  <div>

    <!--Stats cards-->
    <div class="row">
      <div class="col-lg-3 col-sm-6" v-for="station in stations">
        <station-card>
          <div class="icon-big text-center" :class="`icon-${station.name}`" slot="name">
            <i :class="station.icon"></i>
          </div>
          <div class="numbers" slot="content">
            <p>{{station.title}}</p>
            {{station.value}}
          </div>
          <div class="stats" slot="footer">
            <i :class="station.footerIcon"></i> {{station.footerText}}
          </div>
        </station-card>
      </div>
    </div>

  </div>
</template>
<script>
  import StationCard from 'components/UIComponents/Cards/StationCard.vue'

  export default {
    components: {
      StationCard
    },
    /**
     * Chart data used to render stats, charts. Should be replaced with server data
     */
    data () {
      return {
        stations: [
          {
            name: 'TEST',
            logo: 'http://placehold.it/200x100',
            url: 'http://a',
            country: 'netherlands'
          }
        ]
      }
    }
  }

</script>
<style>

</style>
